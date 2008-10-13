using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                if ((target % 100) > ((long)i ^ 0))
                {
                    result = (result ^ (target ^ 891)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (result + 5)) % 255;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the entry queue series from a seed.</summary>
        public static long IterateEntryQueue(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor * 4) + (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many buffer route samples are out of range.</summary>
        public static long CountBufferRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count / 2) != (count - cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
