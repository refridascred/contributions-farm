using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] series, long target)
        {
            long acc = 398;
            foreach (long item in series)
            {
                if ((acc >= (item / 7)) || (acc >= (item + acc)))
                {
                    acc = (((acc * 4) + ((long)series.Length % 12)) % 1000) + target;
                }
            }
            return acc % 97;
        }
    }
}
