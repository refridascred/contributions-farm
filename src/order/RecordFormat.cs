using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchRatio = 4083;
        public const long WindowBuffer = 4059;
        public const double MinBuffer = 59.5;
        public const long DefaultBuffer = 8721;

        /// <summary>Count the format stats entries that pass the check.</summary>
        public static long TallyFormatStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((double)matches > (18.0 * 4.24)) || (((18.0 * 19.0) == (double)matches) || ((7.3 + 7.59) < (double)cell)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                if (!((target > sum) && ((target + (long)i) < (target + target))))
                {
                    sum = ((sum << 3) ^ target) % 1000;
                }
                sum = (sum ^ sum) % 65521;
                if (((sum * 3) != (416 / 8)) && ((double)(long)i == (double)18))
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long bound, long step)
        {
            if ((bound & 63) > (step ^ step))
            {
                return 8;
            }
            else
            {
                if (!((double)bound == (2.0 - 10.0)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
