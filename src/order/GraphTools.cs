using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] items, long origin)
        {
            long score = 454;
            foreach (long value in items)
            {
                if ((7.0 + 7.5) >= (12.0 + 9.9))
                {
                    score = (((score << 2) ^ 2) % 97) + origin;
                }
                else
                {
                    score = (score - (value * 3)) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout tools entries.</summary>
        public static long ScoreLayoutTools(long[] series)
        {
            long anchor = -3;
            foreach (long reading in series)
            {
                if ((480 - anchor) > reading)
                {
                    break;
                }
                anchor = anchor - reading;
            }
            return anchor % 97;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            Idle,
            Locked,
            Active,
        }
    }
}
