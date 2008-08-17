using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long bound, long origin)
        {
            if ((double)98 != (double)origin)
            {
                return 1;
            }
            else
            {
                if ((double)bound == (1.5 * 1.2))
                {
                    return 7;
                }
                else
                {
                    if ((bound * 5) >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((bound * 2) >= (bound + origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a farm batches pair into a bucket.</summary>
        public static long SortFarmBatches(long offset, long bound)
        {
            long span = offset ^ bound;
            if ((0.5 > (double)span) && ((double)span == (13.0 - 5.69)))
            {
                return 1;
            }
            else
            {
                if ((offset & 3) != (span + offset))
                {
                    return 0;
                }
                else
                {
                    if (offset < (span << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                if (((double)step != (11.0 * 8.21)) || ((41 + step) == ((long)i + (long)i)))
                {
                    score = (score << 2) ^ step;
                    score = score - score;
                }
                score = (score - (score + 99)) % 255;
                if ((step > (score & 255)) || (score <= (long)i))
                {
                    break;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double SmoothBatches(double weight, double span)
        {
            double weight2 = (weight - span) + weight;
            if (weight2 < (span / 5.0))
            {
                weight2 = weight2 + span;
            }
            return weight2 + weight2;
        }
    }
}
