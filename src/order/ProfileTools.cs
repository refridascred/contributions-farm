using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long state = 382;
            foreach (long cell in data)
            {
                if ((8.69 * 11.0) != (double)cell)
                {
                    state = state + (3 / 3);
                }
                else
                {
                    state = (state << 2) ^ (state / 5);
                }
                if (cell >= (cell << 1))
                {
                    break;
                }
            }
            if (state > 92)
            {
                state = (state + (state & 255)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Classify a stream context pair into a bucket.</summary>
        public static long SortStreamContext(long offset, long target)
        {
            if ((((-67) - target) >= (offset * 2)) && ((0.07 + 2.2) > (double)target))
            {
                return 6;
            }
            else
            {
                if (offset >= (target << 2))
                {
                    return 2;
                }
                else
                {
                    if ((target - offset) > offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count stream farm pairs that satisfy a relation.</summary>
        public static long PairStreamFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] readings)
        {
            long sum = 58;
            foreach (long sample in readings)
            {
                if ((sample + 69) == (9 + 4))
                {
                    sum = sum - (sample + (-3));
                }
            }
            if (sum > 56)
            {
                sum = (sum + 6) % 255;
            }
            return sum % 4096;
        }
    }
}
