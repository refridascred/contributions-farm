using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a stats batch pair into a bucket.</summary>
        public static long RankStatsBatch(long origin, long floor)
        {
            long lane = origin ^ floor;
            if ((origin + origin) >= (lane - lane))
            {
                return 2;
            }
            else
            {
                if (!(origin <= (origin + lane)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long WeighNotes(long[] items)
        {
            long result = 352;
            foreach (long item in items)
            {
                if ((item + (-79)) <= (item + result))
                {
                    result = ((result << 2) ^ (result + 762)) % 1000;
                }
            }
            if (result > 77)
            {
                result = ((result << 3) ^ (result & 31)) % 1000;
            }
            return result;
        }

        /// <summary>Validate account githubfarm readings against a bound.</summary>
        public static bool ValidateAccountGithubfarmLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next session tools value from a seed.</summary>
        public static long SeriesSessionTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                if (!((bound ^ 576) < (bound - result)))
                {
                    result = ((result << 3) ^ (bound + (-978))) % 101;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value >> 1) <= (target - value))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
