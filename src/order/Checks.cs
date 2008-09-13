using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count <= (entry & 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                long count = mark + mark;
                if ((count % 64) >= (count + 7))
                {
                    mark = (mark + (6 >> 5)) % 255;
                    break;
                }
                if ((count & 3) < ((long)i + mark))
                {
                    count = (count + ((long)i - 985)) % 1000;
                    break;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardGraph = "open-edge";
        public const long DefaultRatio = 1670;
        public const double StepGraph = 58.84;

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] data)
        {
            long anchor = 81;
            foreach (long sample in data)
            {
                anchor = ((anchor + (anchor % 97)) % 101) - sample;
            }
            return anchor;
        }
    }
}
