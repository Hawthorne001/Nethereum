namespace Nethereum.Wallet.UI.Components.WalletAccounts.Mnemonic
{
    public static class MnemonicDetailsLocalizer
    {
        public static class Keys
        {
            public const string MnemonicDetails = "MnemonicDetails";
            public const string Overview = "Overview";
            public const string Security = "Security";
            public const string Accounts = "Accounts";
            public const string Settings = "Settings";

            public const string MnemonicOverview = "MnemonicOverview";
            public const string MnemonicName = "MnemonicName";
            public const string MnemonicType = "MnemonicType";
            public const string CreatedDate = "CreatedDate";
            public const string AccountCount = "AccountCount";
            public const string HasPassphrase = "HasPassphrase";
            public const string NoPassphrase = "NoPassphrase";

            public const string AssociatedAccounts = "AssociatedAccounts";
            public const string NoAccountsMessage = "NoAccountsMessage";
            public const string CreateFirstAccount = "CreateFirstAccount";
            public const string AccountName = "AccountName";
            public const string AccountIndex = "AccountIndex";
            public const string DerivationPath = "DerivationPath";
            public const string Address = "Address";

            public const string RevealSeedPhrase = "RevealSeedPhrase";
            public const string SecurityWarning = "SecurityWarning";
            public const string SecurityWarningMessage = "SecurityWarningMessage";
            public const string SeedPhraseTitle = "SeedPhraseTitle";
            public const string KeepSecure = "KeepSecure";
            public const string KeepSecureMessage = "KeepSecureMessage";
            public const string HideSeedPhrase = "HideSeedPhrase";

            public const string MnemonicLabel = "MnemonicLabel";
            public const string MnemonicLabelPlaceholder = "MnemonicLabelPlaceholder";
            public const string MnemonicLabelHelperText = "MnemonicLabelHelperText";
            public const string SaveLabel = "SaveLabel";
            public const string DeleteMnemonic = "DeleteMnemonic";
            public const string DeleteWarning = "DeleteWarning";
            public const string DeleteWarningMessage = "DeleteWarningMessage";
            public const string DeleteWarningWithAccountsMessage = "DeleteWarningWithAccountsMessage";
            public const string CannotDeleteWithAccounts = "CannotDeleteWithAccounts";

            public const string EditLabel = "EditLabel";
            public const string ViewSeedPhrase = "ViewSeedPhrase";
            public const string ManageAccounts = "ManageAccounts";
            public const string AddAccount = "AddAccount";
            public const string ViewAccount = "ViewAccount";
            public const string Back = "Back";
            public const string Continue = "Continue";
            public const string Save = "Save";
            public const string Cancel = "Cancel";
            public const string Delete = "Delete";
            public const string Confirm = "Confirm";

            public const string Loading = "Loading";
            public const string LoadingMnemonic = "LoadingMnemonic";
            public const string Error = "Error";
            public const string Success = "Success";
            public const string MnemonicNotFound = "MnemonicNotFound";
            public const string NoVaultAvailable = "NoVaultAvailable";
            public const string LabelUpdated = "LabelUpdated";
            public const string MnemonicDeleted = "MnemonicDeleted";
            public const string PasswordLabel = "PasswordLabel";
            public const string InvalidPassword = "InvalidPassword";

            public const string CopyToClipboard = "CopyToClipboard";
            public const string AddressCopied = "AddressCopied";
            public const string SeedPhraseCopied = "SeedPhraseCopied";

            public const string MnemonicTooltip = "MnemonicTooltip";
            public const string PassphraseTooltip = "PassphraseTooltip";
            public const string DerivationPathTooltip = "DerivationPathTooltip";
        }

        // Default English values (these would be replaced by proper localization system)
        public static readonly Dictionary<string, string> DefaultValues = new()
        {
            { Keys.MnemonicDetails, "Seed Phrase Details" },
            { Keys.Overview, "Overview" },
            { Keys.Security, "Security" },
            { Keys.Accounts, "Accounts" },
            { Keys.Settings, "Settings" },

            { Keys.MnemonicOverview, "Seed Phrase Overview" },
            { Keys.MnemonicName, "Name" },
            { Keys.MnemonicType, "HD Wallet (BIP-44)" },
            { Keys.CreatedDate, "Created" },
            { Keys.AccountCount, "Accounts" },
            { Keys.HasPassphrase, "Protected with passphrase" },
            { Keys.NoPassphrase, "No passphrase" },

            { Keys.AssociatedAccounts, "Associated Accounts" },
            { Keys.NoAccountsMessage, "No accounts have been created from this seed phrase yet." },
            { Keys.CreateFirstAccount, "Create First Account" },
            { Keys.AccountName, "Account Name" },
            { Keys.AccountIndex, "Account Index" },
            { Keys.DerivationPath, "Derivation Path" },
            { Keys.Address, "Address" },

            { Keys.RevealSeedPhrase, "Reveal Seed Phrase" },
            { Keys.SecurityWarning, "Security Warning" },
            { Keys.SecurityWarningMessage, "Your seed phrase gives full access to your wallet. Never share it with anyone and store it securely." },
            { Keys.SeedPhraseTitle, "Seed Phrase" },
            { Keys.KeepSecure, "Keep Secure" },
            { Keys.KeepSecureMessage, "Write down your seed phrase and store it in a secure location. Never share it with anyone." },
            { Keys.HideSeedPhrase, "Hide Seed Phrase" },

            { Keys.MnemonicLabel, "Seed Phrase Name" },
            { Keys.MnemonicLabelPlaceholder, "Enter a name for this seed phrase" },
            { Keys.MnemonicLabelHelperText, "Choose a memorable name to help you identify this seed phrase" },
            { Keys.SaveLabel, "Save Name" },
            { Keys.DeleteMnemonic, "Delete Seed Phrase" },
            { Keys.DeleteWarning, "Delete Seed Phrase" },
            { Keys.DeleteWarningMessage, "This will permanently delete the seed phrase and cannot be undone. Make sure you have it backed up." },
            { Keys.DeleteWarningWithAccountsMessage, "This will permanently delete this seed phrase and all {0} associated accounts. This action cannot be undone." },
            { Keys.CannotDeleteWithAccounts, "Cannot delete seed phrase that has associated accounts. Remove all accounts first." },

            { Keys.EditLabel, "Edit Name" },
            { Keys.ViewSeedPhrase, "View Seed Phrase" },
            { Keys.ManageAccounts, "Manage Accounts" },
            { Keys.AddAccount, "Add Account" },
            { Keys.ViewAccount, "View Account" },
            { Keys.Back, "Back" },
            { Keys.Continue, "Continue" },
            { Keys.Save, "Save" },
            { Keys.Cancel, "Cancel" },
            { Keys.Delete, "Delete" },
            { Keys.Confirm, "Confirm" },

            { Keys.Loading, "Loading..." },
            { Keys.LoadingMnemonic, "Loading seed phrase details..." },
            { Keys.Error, "Error" },
            { Keys.Success, "Success" },
            { Keys.MnemonicNotFound, "Seed phrase not found" },
            { Keys.NoVaultAvailable, "No wallet available" },
            { Keys.LabelUpdated, "Seed phrase name updated successfully" },
            { Keys.MnemonicDeleted, "Seed phrase deleted successfully" },
            { Keys.PasswordLabel, "Password" },
            { Keys.InvalidPassword, "Invalid password" },

            { Keys.CopyToClipboard, "Copy to clipboard" },
            { Keys.AddressCopied, "Address copied to clipboard" },
            { Keys.SeedPhraseCopied, "Seed phrase copied to clipboard" },

            { Keys.MnemonicTooltip, "A seed phrase is a series of words that can be used to recover your wallet" },
            { Keys.PassphraseTooltip, "An additional passphrase provides extra security for your seed phrase" },
            { Keys.DerivationPathTooltip, "The path used to generate this account from the seed phrase" }
        };
    }
}