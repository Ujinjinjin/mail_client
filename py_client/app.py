import time
from libraries.mailer import Mailer
from libraries.reader import Reader
from PyQt5 import Qt
import sys


if __name__ == '__main__':
    app = Qt.QApplication(sys.argv)
    notification = Qt.QSystemTrayIcon(app)
    mailer = Mailer('**', '**')
    reader = Reader()

    subject, text = reader.get_text('text.txt')
    customers = reader.get_emails('emails.txt')
    error_messages = []

    mailer.connect()
    for customer in customers:
        try:
            mailer.send_message(subject, text, customer)
            last_sent = customer
        except Exception as e:
            print(f'Error {e} occurred.')
            error_messages.append(customer)

    print(f'Last customer was {last_sent}')
    if len(error_messages) == 0:
        print('All messages was sent')
        notification.show()
        notification.showMessage('PyClient. Completed!', 'All messages was sent successfully!')
    else:
        print('Some messages was not sent. This is list of them:\n{}'.format('\n'.join(error_messages)))
        reader.log('\n'.join(error_messages))
        notification.show()
        notification.showMessage('PyClient. Errors!', 'Some messages was not sent. Please check it from log file.')
