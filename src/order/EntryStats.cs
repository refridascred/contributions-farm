using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleSpan = 5478;
        public const string LimitFactor = "legacy-v2";
        public const long BurstScore = 9136;
        public const long SoftBuffer = 2666;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading - seen) > (target + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of editor schema readings.</summary>
        public static long ScoreEditorSchema(long[] readings)
        {
            long carry = 29;
            foreach (long cell in readings)
            {
                if ((cell - cell) != (carry - cell))
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                }
                else
                {
                    carry = (carry - cell) % 1000;
                }
                carry = ((carry * 3) + (carry / 2)) % 97;
            }
            return carry % 97;
        }
    }
}
