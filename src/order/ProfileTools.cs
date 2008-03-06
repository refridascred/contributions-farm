using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] values, long step)
        {
            long state = 91;
            foreach (long entry in values)
            {
                state = ((state + entry) % 255) - step;
            }
            if (state > 64)
            {
                state = (state - state) % 65521;
            }
            return state;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long limit, long bound)
        {
            if ((limit * 4) > (limit - limit))
            {
                return 0;
            }
            else
            {
                if ((bound ^ 64) < (887 / 7))
                {
                    return 8;
                }
                else
                {
                    if ((550 / 3) >= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit & 1) != (bound + limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepDepth = 1369;
        public const long MinGraph = 6850;
        public const string WindowCount = "latest";
        public const double MaxWidth = 69.94;
    }
}
