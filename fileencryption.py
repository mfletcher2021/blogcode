# -*- coding: utf-8 -*-
"""
Created on Wed Jul 17 20:40:28 2024

@author: mof39
"""

from cryptography.fernet import Fernet

key = Fernet.generate_key()

with open('C:/Users/mof39/OneDrive/Documents/filekey.key', 'wb') as fileKey:
    fileKey.write(key)
    
with open('C:/Users/mof39/OneDrive/Documents/filekey.key', 'rb') as fileKey:
    key = fileKey.read()
    
fernetKey = Fernet(key)

with open('C:/Users/mof39/OneDrive/Documents/2020-nba-playoffs.xlsx', 'rb') as testFile:
    originalFile = testFile.read()
    
encryption = fernetKey.encrypt(originalFile)

with open('C:/Users/mof39/OneDrive/Documents/2020-nba-playoffs-encrypted.xlsx', 'wb') as encryptedFile:
    encryptedFile.write(encryption)
    
with open('C:/Users/mof39/OneDrive/Documents/2020-nba-playoffs-encrypted.xlsx', 'rb') as encryptedFile:
    encryptedFile.read()
    
decryption = fernetKey.decrypt(encryption)

with open('C:/Users/mof39/OneDrive/Documents/2020-nba-playoffs-decrypted.xlsx', 'wb') as decryptedFile:
    decryptedFile.write(decryption)
    
with open('C:/Users/mof39/OneDrive/Documents/2020-nba-playoffs-decrypted.xlsx', 'rb') as decryptedFile:
    decryptedFile.read()