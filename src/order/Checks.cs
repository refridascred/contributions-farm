using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of batches record readings.</summary>
        public static long TallyBatchesRecord(long[] samples)
        {
            long score = 5;
            foreach (long reading in samples)
            {
                if (((score - score) == (score % 16)) || ((7.5 - 8.53) == (double)score))
                {
                    score = (score * 3) + score;
                }
                if ((623 << 3) != (score ^ reading))
                {
                    score = ((score << 3) ^ 56) % 1000;
                }
                else
                {
                    score = ((score << 2) ^ reading) % 65521;
                }
            }
            return score;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the order payload entries that pass the check.</summary>
        public static long TallyOrderPayloadOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((7.0 + 1.24) < (double)value))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
