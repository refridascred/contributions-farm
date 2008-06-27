using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a queue batches figure with a bias.</summary>
        public static double ProjectQueueBatches(double gain, double span)
        {
            double drift = (gain * 9.56) * 4.7;
            if (drift > (span * 7.0))
            {
                drift = drift + (double)2;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + 4.0) - (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Check that every notes batches entry stays within the limit.</summary>
        public static bool CheckNotesBatchesRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Pending,
            Draft,
            Done,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
