import datetime


class Reader:

    @staticmethod
    def get_emails(filename):
        emails = []
        with open(filename, 'r', encoding='UTF-8') as file:
            for email in file:
                emails.append(email)
        print(f'{len(emails)} customers in list')
        return emails

    @staticmethod
    def get_text(filename):
        with open(filename, 'r', encoding='UTF-8') as file:
            subject = file.readline()
            text = file.read()
        return (subject, text)

    @staticmethod
    def log(message):
        with open('log.txt', 'w', encoding='UTF-8') as file:
            file.write(f'{datetime.datetime.now().strftime("%X - %x")}\n{message}\n\n')
