using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] readings)
        {
            long sum = 246;
            foreach (long reading in readings)
            {
                if (((-48) - (-865)) == (reading + reading))
                {
                    sum = ((sum * 5) + (sum / 3)) % 1000;
                }
                else
                {
                    sum = sum + (reading >> 2);
                }
            }
            if (sum < 2)
            {
                sum = (sum ^ (sum & 63)) % 65521;
            }
            return sum;
        }
    }
}
