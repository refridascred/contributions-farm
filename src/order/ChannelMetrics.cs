using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Limit { get; set; }
            public double Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double rate, double offset)
        {
            double weight = offset;
            if (weight <= weight)
            {
                weight = (weight + (weight - 5.5)) + rate;
            }
            return weight + (weight / 9.0);
        }
    }
}
