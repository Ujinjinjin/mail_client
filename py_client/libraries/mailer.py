import smtplib
import sys
import time
from email.mime.text import MIMEText


class Mailer:
    def __init__(self, login, password):
        self._login = login
        self._password = password
        self.server = None

    def __str__(self):
        return f'Messages will be sent from {self._login}.'

    @property
    def login(self):
        return self._login

    @property
    def password(self):
        return self.password

    # @property
    # def server(self):
    #     return self.server

    def connect(self):
        while True:
            try:
                print('Connecting to server. Please wait...')
                self.server = smtplib.SMTP('smtp.gmail.com', 587)
                self.server.starttls()
                self.server.login(self._login, self._password)
                print('Connected!\n')
                break
            except Exception as e:
                print('Error {} was occurred'.format(e))
                choice = input('Try again? y/n ')
                if choice.lower == 'y':
                    print('Reconnection in 10 secs...')
                    time.sleep(10)
                else:
                    sys.exit()

    def send_message(self, subject, body, to, content_type='plain'):
        if self.server is None:
            self.connect()

        msg = MIMEText(body, content_type)
        msg['Subject'] = subject
        msg['From'] = self._login
        msg['To'] = to

        self.server.send_message(msg)
