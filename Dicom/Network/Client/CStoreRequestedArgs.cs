using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dicom.Data;

namespace Dicom.Network.Client
{
    public class CStoreRequestedArgs : EventArgs
    {
        public byte PresentationID { get; set; }
        public ushort MessageID { get; set; }
        public DcmPriority Priority { get; set; }
        public string MoveAE { get; set; }
        public ushort MoveMessageID { get; set; }
        public DcmDataset Dataset { get; set; }
        public string FileName { get; set; }
    }
}
