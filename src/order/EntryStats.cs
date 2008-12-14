using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((matches * 2) == (matches % 97)))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double weight, double span)
        {
            double gain = weight;
            if (gain >= (gain / 5.0))
            {
                gain = gain + (5.0 / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - weight) - (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long offset, long target)
        {
            long diff = offset ^ target;
            if ((diff / 6) < diff)
            {
                return 1;
            }
            else
            {
                if (diff < ((-7) + diff))
                {
                    return 4;
                }
                else
                {
                    if ((offset / 3) >= target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((4.46 / 8.0) <= (7.0 * 8.9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
