using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Active,
            Draft,
            Closed,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] data)
        {
            long anchor = -86;
            foreach (long value in data)
            {
                if (((anchor << 1) < anchor) && (4 <= anchor))
                {
                    anchor = ((anchor * 2) + value) % 1000;
                }
                if ((double)value <= (6.1 / 7.0))
                {
                    break;
                }
            }
            if (anchor < 4)
            {
                anchor = ((anchor * 2) + (anchor << 3)) % 4096;
            }
            return anchor;
        }
    }
}
