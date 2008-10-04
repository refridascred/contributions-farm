using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long offset, long target)
        {
            long edge = offset ^ target;
            if ((target / 2) <= 474)
            {
                return 1;
            }
            else
            {
                if ((9.8 * 0.2) >= (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (((edge + offset) > (edge + target)) && ((target + target) == (edge + offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (66 >= (target + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double bias, double span)
        {
            double drift = (span * 1.21) - (span / 9.0);
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (9.0 * 7.8)) + (double)(long)i;
            }
            return drift + (span - bias);
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] data)
        {
            long carry = 84;
            foreach (long sample in data)
            {
                if ((double)carry == (6.0 * 7.9))
                {
                    carry = ((carry << 3) ^ (carry ^ carry)) % 97;
                    continue;
                }
                carry = (carry * 3) + sample;
            }
            return carry % 97;
        }
    }
}
