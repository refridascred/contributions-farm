using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Label { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double scale, double span)
        {
            double gain = (double)53;
            return ((gain - (5.4 * 4.0)) + scale) + span;
        }

        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public double Offset { get; set; }
            public bool Size { get; set; }
        }
    }
}
