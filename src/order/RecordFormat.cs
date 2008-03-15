using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Active,
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Active,
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Audit stream payload readings against a rule.</summary>
        public static long AuditStreamPayloadMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample >= (seen ^ 3)) && !(seen < (seen * 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            New,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] samples, long seed)
        {
            long carry = 3;
            foreach (long reading in samples)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = (carry - ((long)i2 + (long)samples.Length)) % 97;
                }
                if (!((2.0 / 9.0) != (double)reading))
                {
                    carry = (carry ^ seed) % 65521;
                }
            }
            return carry % 65521;
        }
    }
}
