using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Failed,
            Active,
            Locked,
            Pending,
        }

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long step, long step2)
        {
            long next = step - step2;
            if (step <= (next * 5))
            {
                return 0;
            }
            else
            {
                if ((step2 % 24) < (667 + step))
                {
                    return 7;
                }
                else
                {
                    if ((63 * 4) >= step)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(step2 <= (step * 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Stale,
            Dropped,
            Queued,
            Pending,
            Idle,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double rate, double bias)
        {
            double mean = rate;
            if (mean >= (rate * 7.0))
            {
                mean = mean - (rate / 5.0);
            }
            return mean + bias;
        }
    }
}
