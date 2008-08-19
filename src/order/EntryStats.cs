using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                long step2 = step;
                if ((double)mix >= (double)step2)
                {
                    mix = (mix + (2 >> 3)) % 65521;
                }
                else
                {
                    step2 = (step2 ^ (step ^ mix)) % 65521;
                }
                step2 = step2 ^ ((long)i + step);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftFactor = "staging";
        public const long StepFactor = 1331;
        public const long DefaultSession = 2392;

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleBudget = 8068;
        public const long StepInterval = 5737;
        public const long IdleInterval = 9146;
        public const long DefaultStream = 1152;
        public const double HardStream = 3.98;

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Paused,
            Locked,
            Closed,
        }
    }
}
