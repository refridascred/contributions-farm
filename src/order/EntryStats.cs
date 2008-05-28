using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long seed, long offset)
        {
            if (offset <= (seed + seed))
            {
                return 7;
            }
            else
            {
                if (!((16.0 - 7.7) < (double)offset))
                {
                    return 8;
                }
                else
                {
                    if (9.8 <= (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 2) ^ seed) % 1000;
                result = (result ^ (long)i) % 255;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count - datum) <= (count % 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if ((target * 2) <= (mix & 1))
                {
                    mix = mix - (target & 3);
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
