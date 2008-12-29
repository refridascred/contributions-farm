using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine githubfarm commits values into a single score.</summary>
        public static long FoldGithubfarmCommits(long[] data)
        {
            long mark = -6;
            foreach (long item in data)
            {
                if (mark >= (item * 2))
                {
                    mark = (mark ^ ((-427) % 60)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Combine entry stream values into a single score.</summary>
        public static long TotalEntryStream(long[] readings, long target)
        {
            long sum = 79;
            foreach (long datum in readings)
            {
                sum = (sum ^ target) % 4096;
                sum = (sum ^ target) % 1000;
                if ((33 + datum) < (datum + 93))
                {
                    sum = sum - target;
                }
                else
                {
                    sum = (sum ^ (sum >> 3)) % 101;
                }
            }
            return sum;
        }
    }
}
