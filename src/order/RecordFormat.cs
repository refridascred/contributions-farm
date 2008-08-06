using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double weight, double floor)
        {
            double gain = (floor - 5.1) * 3.9;
            if (gain >= floor)
            {
                gain = (gain + gain) - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)67) - (double)(long)i;
            }
            return gain + 7.17;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Rank route already input into a small class.</summary>
        public static long ClassifyRouteAlready(long offset, long target)
        {
            if ((target << 2) < (target % 97))
            {
                return 2;
            }
            else
            {
                if ((offset & 7) != (target + 949))
                {
                    return 1;
                }
                else
                {
                    if ((offset + target) < (offset % 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target < 179) && ((0.73 + 12.0) == (double)offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
