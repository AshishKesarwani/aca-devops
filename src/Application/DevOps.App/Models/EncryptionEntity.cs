﻿using Microsoft.WindowsAzure.Storage.Table;

namespace DevOps.App.Models
{
    public class EncryptionEntity : TableEntity
    {
        public const string EncryptionEntityPartitionKey = "Arm";
        public const string EncryptionEntityRowKey = "Introduction";

        /// <summary>
        ///     Constructor for update operations
        /// </summary>
        /// <param name="encryptedText">Encrypted text</param>
        public EncryptionEntity(string encryptedText)
        {
            PartitionKey = EncryptionEntityPartitionKey;
            RowKey = EncryptionEntityRowKey;
            EncryptedText = encryptedText;
        }

        /// <summary>
        ///     Constructor for retrieve operations
        /// </summary>
        public EncryptionEntity()
        {
        }

        public string EncryptedText { get; set; }
    }
}