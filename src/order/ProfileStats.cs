using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 7605;
        public const string IdleFarm = "primary-edge";
        public const long MinRatio = 8577;
        public const long CacheFarm = 1141;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two profile notes measurements.</summary>
        public static double ProjectProfileNotes(double weight, double span)
        {
            double drift = (double)977 * 3.0;
            if (drift >= 3.0)
            {
                drift = ((drift + drift) - weight) - span;
            }
            return drift + drift;
        }

        /// <summary>Check that every batch editor entry stays within the limit.</summary>
        public static bool CheckBatchEditorLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
