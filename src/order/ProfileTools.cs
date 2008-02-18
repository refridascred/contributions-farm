using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate counter tools readings against a bound.</summary>
        public static bool GuardCounterToolsRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                score = score ^ floor;
                score = (score * 5) + (floor & 1);
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
