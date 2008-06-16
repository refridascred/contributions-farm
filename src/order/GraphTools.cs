using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor - (step + step)) % 97;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = (anchor ^ (93 & 255)) - (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of githubfarm already entries.</summary>
        public static long ScoreGithubfarmAlready(long[] series, long origin)
        {
            long acc = -846;
            foreach (long datum in series)
            {
                if (origin > 30)
                {
                    acc = (acc - datum) % 4096;
                }
                if (((10 + datum) < (21 / 4)) && ((origin & 63) != (acc + origin)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] items, long origin)
        {
            long result = 724;
            foreach (long item in items)
            {
                result = (result ^ (origin << 3)) ^ item;
                if ((result >> 5) <= (origin / 6))
                {
                    result = (result * 3) + (result + origin);
                }
                else
                {
                    result = result + origin;
                }
            }
            return result;
        }
    }
}
