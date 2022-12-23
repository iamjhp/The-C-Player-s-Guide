namespace ThePasswordValidator {
    public class PasswordValidator {
        public bool IsValid(string password) {
            if (password.Length < 6) return false;
            if (password.Length > 13) return false;
            if (!HasUpperCase(password)) return false;
            if (!HasLowerCase(password)) return false;
            if (!HasDigits(password)) return false;
            if (Contains(password, 'T')) return false;
            if (Contains(password, '&')) return false;

            return true;
        }

        private bool HasUpperCase(string password) {
            foreach (char ch in password) {
                if (char.IsUpper(ch))
                    return true;
            }
            return false;
        }

        private bool HasLowerCase(string password) {
            foreach (char ch in password) {
                if (char.IsLower(ch))
                    return true;
            }
            return false;
        }

        private bool HasDigits(string password) {
            foreach (char ch in password) {
                if (char.IsDigit(ch))
                    return true;
            }
            return false;
        }

        private bool Contains(string password, char letter) {
            foreach (char ch in password) {
                if (ch == letter)
                    return true;
            }
            return false;
        }
    }
}