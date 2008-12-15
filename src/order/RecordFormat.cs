using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long bound, long seed)
        {
            if ((1.9 + 1.0) > (double)seed)
            {
                return 5;
            }
            else
            {
                if ((5.94 / 2.0) < (double)seed)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] values, long target)
        {
            long anchor = 1;
            foreach (long datum in values)
            {
                if ((datum & 31) <= (target + target))
                {
                    anchor = (anchor << 3) ^ (target * 2);
                }
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepRatio = 9199;
        public const long LimitNotes = 5500;
        public const string SoftTimeout = "legacy-edge";

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                if ((step ^ score) > (892 + score))
                {
                    score = (score ^ score) % 97;
                }
                if ((step + step) == (96 >> 2))
                {
                    score = ((score * 5) + (score * 3)) % 65521;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitLevel = 1455;
        public const long BaseMetrics = 2515;
        public const string LimitFactor = "primary-v2";
    }
}
