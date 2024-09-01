# -*- coding: utf-8 -*-
"""
Created on Fri Aug 30 16:15:53 2024

@author: mof39
"""

import hashlib

text = 'Michaels Programming Bytes: Byte sized programming classes for all coding learners'

SHA256 = hashlib.sha256(text.encode())
print(SHA256.hexdigest())

SHA384 = hashlib.sha384(text.encode())
print(SHA384.hexdigest())

SHA224 = hashlib.sha224(text.encode())
print(SHA224.hexdigest())

SHA512 = hashlib.sha512(text.encode())
print(SHA512.hexdigest())

SHA1 = hashlib.sha1(text.encode())
print(SHA1.hexdigest())