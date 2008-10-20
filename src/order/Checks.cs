using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                if ((step + carry) > (step - carry))
                {
                    carry = ((carry << 3) ^ (carry * 5)) % 97;
                    carry = (carry + (long)i) % 1000;
                    break;
                }
                else
                {
                    carry = (carry + (step >> 2)) % 255;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry - (step & 63)) % 4096) - (long)i2;
                }
                carry = ((carry << 3) ^ (228 - 82)) % 101;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Retry,
            Ready,
            New,
        }

        /// <summary>Validate cluster notes readings against a bound.</summary>
        public static bool CheckClusterNotesBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double rate, double offset)
        {
            double drift = 7.9 * 16.0;
            if (drift < (7.88 * 8.6))
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift + (rate + offset);
        }
    }
}
