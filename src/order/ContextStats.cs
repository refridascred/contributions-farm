using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long seed, long step)
        {
            if (!((83 ^ step) >= (seed - step)))
            {
                return 2;
            }
            else
            {
                if ((step - step) < (seed & 63))
                {
                    return 7;
                }
                else
                {
                    if (((step * 4) >= (step + 5)) && (seed < (step >> 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((step - seed) > (step + 6)) && ((step - 0) < (step + step)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Rank { get; set; }
            public long Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 0.94;
        public const long StepWidth = 3118;
        public const long StepSize = 5375;

        /// <summary>Validate notes context readings against a bound.</summary>
        public static bool GuardNotesContextLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
