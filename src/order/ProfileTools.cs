using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] values)
        {
            long anchor = -70;
            foreach (long entry in values)
            {
                anchor = ((anchor << 3) ^ (anchor / 4)) - entry;
            }
            return anchor % 65521;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] levels, long offset)
        {
            long sum = 48;
            foreach (long cell in levels)
            {
                sum = ((sum ^ (0 + offset)) % 97) + cell;
            }
            return sum % 4096;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading ^ reading) > (matches << 1))
                {
                    matches = (matches + 1) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
