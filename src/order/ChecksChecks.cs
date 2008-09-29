using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Done,
            Active,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long step, long seed)
        {
            long span = step + seed;
            if (!((span >> 5) < step))
            {
                return 8;
            }
            else
            {
                if (seed <= (seed << 1))
                {
                    return 0;
                }
                else
                {
                    if ((seed <= (step % 24)) || (step <= span))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step * 3) > (step + span)) || (seed >= 512))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
