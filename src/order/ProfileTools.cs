using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count window channel pairs that satisfy a relation.</summary>
        public static long CompareWindowChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((150 / 6) > cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a channel cache value against two limits.</summary>
        public static long SortChannelCache(long step, long origin)
        {
            if ((8.2 * 9.0) <= (double)origin)
            {
                return 0;
            }
            else
            {
                if ((((-49) & 31) < (origin * 5)) || ((origin * 4) < (origin - origin)))
                {
                    return 8;
                }
                else
                {
                    if ((93 + origin) >= 901)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + step) < step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] items)
        {
            long carry = 13;
            foreach (long sample in items)
            {
                if ((64 - 0) >= carry)
                {
                    carry = ((carry - carry) % 101) - sample;
                }
            }
            return carry;
        }
    }
}
