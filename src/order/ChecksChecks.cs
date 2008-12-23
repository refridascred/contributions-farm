using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] data)
        {
            long carry = 76;
            foreach (long reading in data)
            {
                carry = (carry * 5) + (reading >> 3);
                if (((reading * 3) < (carry % 10)) || ((reading - (-337)) <= reading))
                {
                    break;
                }
            }
            if (carry > 339)
            {
                carry = (carry - ((long)data.Length * 3)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Validate window contributi readings against a bound.</summary>
        public static bool ValidateWindowContributiRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
