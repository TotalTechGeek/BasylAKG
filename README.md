# Basyl Asymmetric Key Generator

### Welcome
Modern Cryptography is the future. Asymmetric Encryption provides us with the ability to do amazing things, like safely communicate with our banks, or our friends. This tool is a way of making modern cryptography more accessible to the average user. How, you might ask? This project allows you to generate [RSA](https://en.wikipedia.org/wiki/RSA_(cryptosystem)) and [Elliptic Curve](https://en.wikipedia.org/wiki/Elliptic_curve_cryptography) keys from a password, or even a file. 

It is strongly recommended you check out our other page.

### Isn't this insecure?
There are quite a few cryptographers that will criticize the concept of being able to generate your private key from a password. A stigma has been created, and most private key generation algorithms pull their randomness from what is considered to be "truly random number generators". There is an unsafe assumption that this is somehow more secure than generating a private key from a password.

Since the private keys must be stored somewhere, seeing that they can't be regenerated, they are often encrypted with a password. Many people will use 10-12 letter passwords. Even using a 256 bit encryption algorithm, these private key files are only protected by 80-96 bits. 

AES is a much faster algorithm to perform than a private key derivation algorithm. Realistically, It is much easier to attempt a brute force of your key file than attempt to bruteforce the generation of the private key. 

Also, the PRNG that is used has been tested extensively to show that it is cryptographically secure.   

TL;DR this isn't any less secure than storing your private key file on your computer.

### More Information

Additional Information about the Tool :
 
   http://thecreatorjames.github.io/BasylAKG

For File Encryption :

  https://github.com/TheCreatorJames/BasylEncryptionTool
 
Related Projects :

   https://github.com/TheCreatorJames/BESLibrary

   https://github.com/TheCreatorJames/BESLibraryCPP
