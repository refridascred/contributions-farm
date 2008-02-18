using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] samples, long offset)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                if ((cell <= (cell - offset)) || ((mix / 5) <= cell))
                {
                    mix = (mix ^ (6 - cell)) % 65521;
                }
                if ((907 * 2) == (mix ^ mix))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Flag { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] items)
        {
            long score = 3;
            foreach (long value in items)
            {
                if (score >= value)
                {
                    score = ((score * 2) + (71 + 84)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double bias, double bias2)
        {
            double drift = (double)(0 << 1);
            return (drift + bias2) + bias;
        }
    }
}
