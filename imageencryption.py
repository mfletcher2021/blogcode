# -*- coding: utf-8 -*-
"""
Created on Sun Aug 18 21:42:18 2024

@author: mof39
"""

from cryptography.fernet import Fernet

imageKey = Fernet.generate_key()

with open(r'C:/Users/mof39/OneDrive/Documents/imageKey.key', 'wb') as keyFile:
    keyFile.write(imageKey)
    
with open(r'C:/Users/mof39/OneDrive/Documents/imageKey.key', 'rb') as keyFile:
    encryptionKey = keyFile.read()
    
fernetEncryptionKey = Fernet(encryptionKey)

with open(r'C:/Users/mof39/Downloads/20240728_132146.jpg', 'rb') as image:
    originalImage = image.read()
    
encryptedImage = fernetEncryptionKey.encrypt(originalImage)

with open(r'C:/Users/mof39/OneDrive/Documents/encryptedImage.jpg', 'wb') as image:
    image.write(encryptedImage)
    
with open(r'C:/Users/mof39/OneDrive/Documents/imageKey.key', 'rb') as keyFile:
    imageKeyFile = keyFile.read()
    
fernetDecryptionKey = Fernet(imageKeyFile)

with open(r'C:/Users/mof39/OneDrive/Documents/encryptedImage.jpg', 'rb') as image:
    encryptedImage = image.read()
    
decryptedImage = fernetDecryptionKey.decrypt(encryptedImage)

with open(r'C:/Users/mof39/OneDrive/Documents/decryptedImage.jpg', 'wb') as image:
    image.write(decryptedImage)