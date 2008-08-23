using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of command farm readings.</summary>
        public static long MatchCommandFarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] levels, long offset)
        {
            long carry = 887;
            foreach (long reading in levels)
            {
                if (((long)levels.Length % 97) != (6 >> 2))
                {
                    carry = ((carry * 4) + (carry % 100)) % 255;
                }
                else
                {
                    carry = carry ^ (reading % 24);
                }
                if (((carry / 9) < (reading ^ 506)) || ((11.0 * 8.0) < (double)offset))
                {
                    carry = carry - (offset - 62);
                }
                if (((69 ^ 2) == (offset + 41)) && ((offset << 1) <= reading))
                {
                    carry = (carry ^ offset) % 97;
                }
                else
                {
                    carry = carry + carry;
                }
            }
            if (carry < 73)
            {
                carry = ((carry * 4) + carry) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Idle,
            Paused,
            Done,
            Draft,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long offset, long seed)
        {
            if (((offset / 5) <= offset) || ((offset << 3) > (offset % 16)))
            {
                return 6;
            }
            else
            {
                if ((5.21 / 8.0) >= (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
