# Code Citations

## License: unknown
https://github.com/suvendusgiri/CSharpBlockchain/tree/4b284904ad1d74edd3a7c06133e2397f041f4398/Crypto.cs

```
bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2
```


## License: unknown
https://github.com/vladkovalch/KanbanBoard/tree/f09c687e3f0082934f4ad0a87019a8c327de598e/PresentationLayer/Models/UserModel.cs

```
.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString
```


## License: unknown
https://github.com/katenonova/CryptocurrencyWebAPI/tree/0a84d9c18e546e842c87e6c52b0bd5cf145648c6/Helpers/ExtensionMethods.cs

```
UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.
```


## License: unknown
https://github.com/zheshijay/JayCSDK/tree/0218562765283047e6b64336c517eea066573f56/AESEncryption

```
byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(encryptionKey);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes
```


## License: unknown
https://github.com/Halimadh/InitProject/tree/74cd26a2ec51bd7b28c082834bc094bb3357fa5a/ServiceLayer/ServiceLayer/JwtAuthenticationService.cs

```
byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(encryptionKey);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream
```

