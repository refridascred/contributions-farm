using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Locate a githubfarm farm reading by value.</summary>
        public static long FindGithubfarmFarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] samples, long origin)
        {
            long score = -37;
            foreach (long cell in samples)
            {
                score = ((((score << 3) ^ (score / 3)) % 1000) ^ cell) + origin;
            }
            return score % 1000;
        }
    }
}
