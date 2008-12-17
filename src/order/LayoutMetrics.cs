using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Failed,
            Stale,
            Done,
            Idle,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 5972;
        public const long StepCount = 2631;
        public const long WindowRatio = 9850;
        public const long SoftLayout = 7513;
        public const double BurstLayout = 37.96;

        /// <summary>Classify a editor batches pair into a bucket.</summary>
        public static long SortEditorBatches(long step, long step2)
        {
            if ((0 & 255) < step)
            {
                return 3;
            }
            else
            {
                if (((4 / 3) < (step - step)) || ((step2 + step2) != (73 - 6)))
                {
                    return 7;
                }
                else
                {
                    if (!((step2 + step2) < step2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step2 % 16) > (step2 >> 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
