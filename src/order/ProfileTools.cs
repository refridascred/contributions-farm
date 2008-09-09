using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 910;
        public const long WindowRatio = 403;
        public const long StepChecks = 9691;
        public const double CacheTimeout = 61.46;
        public const long WindowFactor = 1284;

        /// <summary>Grade a support profile value against two limits.</summary>
        public static long ClassifySupportProfile(long offset, long target)
        {
            long offset2 = offset - target;
            if ((678 >> 4) < (1 + offset2))
            {
                return 2;
            }
            else
            {
                if (((target * 3) >= (95 ^ 4)) || ((offset2 / 6) <= offset))
                {
                    return 5;
                }
                else
                {
                    if (((target - offset2) >= (offset2 / 8)) && (target <= (offset + offset2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up payload editor samples.</summary>
        public static long MatchPayloadEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit order route readings against a rule.</summary>
        public static long CountOrderRouteGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (tally >= (value << 3))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long origin, long target)
        {
            if (target > (origin + target))
            {
                return 6;
            }
            else
            {
                if ((target + 8) > (origin << 2))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
