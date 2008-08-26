using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate farm record readings against a bound.</summary>
        public static bool CheckFarmRecordRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long origin, long offset)
        {
            long lane = origin ^ offset;
            if ((offset ^ offset) == ((-39) % 12))
            {
                return 6;
            }
            else
            {
                if ((9.28 / 9.0) == (double)lane)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin == (1.0 - 2.05))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double ratio, double span)
        {
            double ratio2 = 8.5;
            return ((ratio2 - (double)20) + ratio) + span;
        }

        /// <summary>Audit record format readings against a rule.</summary>
        public static long MeasureRecordFormatMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((double)entry < (6.5 + 7.12)) || ((hits - 427) <= hits))
                {
                    hits = (hits + 2) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
