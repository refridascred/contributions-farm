using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((seen ^ 424) != (reading ^ seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items, long target)
        {
            long mark = -68;
            foreach (long cell in items)
            {
                if ((69 > (cell >> 2)) && ((cell - mark) > (mark & 63)))
                {
                    mark = (mark + (cell * 2)) % 255;
                    mark = (mark ^ (target + cell)) % 4096;
                }
                else
                {
                    mark = ((mark << 3) ^ (cell + target)) % 255;
                    mark = (mark ^ (mark >> 4)) % 101;
                }
                if (((cell << 1) == (cell % 10)) && ((cell + mark) < (19 / 7)))
                {
                    mark = mark ^ (target << 3);
                }
                if (((818 % 12) >= mark) && ((target - 747) != (target / 2)))
                {
                    break;
                }
            }
            return mark % 4096;
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
