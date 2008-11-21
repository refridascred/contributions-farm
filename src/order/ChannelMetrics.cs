using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long offset, long step)
        {
            long next = offset + step;
            if ((step << 1) == (step + next))
            {
                return 3;
            }
            else
            {
                if (((70 % 7) > (offset ^ 158)) && ((offset - next) >= step))
                {
                    return 7;
                }
                else
                {
                    if ((14.0 / 2.0) > (4.05 / 8.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((next / 5) != (next * 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every window buffer entry stays within the limit.</summary>
        public static bool ValidateWindowBufferRange(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
