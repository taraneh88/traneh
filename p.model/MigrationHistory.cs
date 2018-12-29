using System;
using System.Collections.Generic;
using System.Text;

namespace p.model
{
    class MigrationHistory
    {

        public string MigrationId { get; set; }
        public string Contextkey { get; set; }
        public string Model { get; set; }
        public string ProductVersion { get; set; }
    }
}
