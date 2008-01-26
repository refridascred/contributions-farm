using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of command batch readings.</summary>
        public static long MatchCommandBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long step)
        {
            long result = step;
            for (int i = 0; i < 4; i++)
            {
                result = (result * 3) + (step ^ 96);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Draft,
            Closed,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long bound, long limit)
        {
            if (((751 + limit) <= (5 + limit)) || ((limit - limit) >= (limit & 1)))
            {
                return 4;
            }
            else
            {
                if (((limit - bound) <= 22) && ((8 + bound) == (limit >> 4)))
                {
                    return 3;
                }
                else
                {
                    if (limit > 6)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
