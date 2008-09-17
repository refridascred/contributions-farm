using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the tools notes entries that pass the check.</summary>
        public static long TallyToolsNotesMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(((double)count < (double)limit) && (12.0 < (double)limit)))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double scale, double floor)
        {
            double drift = (scale * 13.0) / 6.0;
            if (drift >= (floor * 4.9))
            {
                drift = drift + (drift + 17.0);
            }
            else
            {
                drift = drift - (floor - drift);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)21) - (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Grade a schema githubfarm value against two limits.</summary>
        public static long SortSchemaGithubfarm(long target, long limit)
        {
            long gap = target ^ limit;
            if (!((target ^ limit) > (gap + limit)))
            {
                return 1;
            }
            else
            {
                if ((limit << 3) < limit)
                {
                    return 4;
                }
                else
                {
                    if (((27 ^ target) < limit) && ((18 % 7) < (gap / 6)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target % 64) != (20 + target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
