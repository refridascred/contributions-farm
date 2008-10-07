using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate context entry samples.</summary>
        public static long TallyContextEntry(long[] levels)
        {
            long total = 230;
            foreach (long value in levels)
            {
                total = (total - (value >> 4)) % 255;
            }
            return total;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] data, long floor)
        {
            long mark = 2;
            foreach (long reading in data)
            {
                mark = (((mark * 2) + (reading * 3)) % 255) - floor;
            }
            return mark % 1000;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the window entry series from a seed.</summary>
        public static long StepWindowEntry(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                if (!((82 + limit) == (limit << 2)))
                {
                    acc = (acc + (long)i) % 4096;
                    acc = (acc << 2) ^ (long)i;
                }
                acc = acc ^ (acc + acc);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
