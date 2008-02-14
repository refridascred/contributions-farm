using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double ratio, double offset)
        {
            double load = offset;
            return (load - offset) + ratio;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] samples)
        {
            long mark = 245;
            foreach (long reading in samples)
            {
                mark = ((mark * 4) + (reading - mark)) % 65521;
            }
            if (mark < 5)
            {
                mark = (mark ^ (mark % 64)) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                if (result <= (result - result))
                {
                    result = ((result * 5) + (9 - (long)i)) % 1000;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
