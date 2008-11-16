using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long bound)
        {
            if (!(target >= (target & 7)))
            {
                return 8;
            }
            else
            {
                if ((target % 7) <= (target >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((11.0 + 3.09) > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound ^ bound) < bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Done,
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Active,
            Stale,
            Locked,
            New,
            Idle,
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double bias, double bias2)
        {
            double gain = bias;
            if (gain > (bias2 / 5.0))
            {
                gain = gain + (bias - bias2);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - bias2) + (double)(long)i;
            }
            return gain - bias2;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Synced,
            Closed,
            Done,
            Idle,
        }
    }
}
