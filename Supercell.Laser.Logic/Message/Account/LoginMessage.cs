namespace Supercell.Laser.Logic.Message.Account
{
    using Supercell.Laser.Titan.DataStream;
    using Supercell.Laser.Titan.Math;
    using Supercell.Laser.Titan.Message;

    public class LoginMessage : PiranhaMessage
    {
        public const int MESSAGE_TYPE = 10101;

        private LogicLong m_accountId;

        private bool m_androidClient;
        private bool m_advertisingEnabled;

        private int m_scramblerSeed;
        private int m_clientMajorVersion;
        private int m_clientBuildVersion;
        private int m_appStore;

        private string m_androidId;
        private string m_adid;
        private string m_device;
        private string m_imei;
        private string m_macAddress;
        private string m_openUDID;
        private string m_osVersion;
        private string m_advertisingId;
        private string m_appVersion;
        private string m_passToken;
        private string m_preferredDeviceLanguage;
        private string m_resourceSha;
        private string m_udid;
        private string m_kunlunSSO;
        private string m_kunlunUserId;

        public LoginMessage(short version, ByteStream stream) : base(version, stream)
        {

        }
        public override void Encode()
        {
            base.Encode();

            this.m_stream.WriteLong(this.m_accountId);
            this.m_stream.WriteString(this.m_passToken);
            this.m_stream.WriteInt(this.m_clientMajorVersion);
            this.m_stream.WriteInt(0);
            this.m_stream.WriteInt(this.m_clientBuildVersion);
            this.m_stream.WriteString(this.m_resourceSha);
            this.m_stream.WriteString(this.m_udid);
            this.m_stream.WriteVInt(1);
            this.m_stream.WriteVInt(0);
            this.m_stream.WriteString(this.m_openUDID);
            this.m_stream.WriteString(null);
            this.m_stream.WriteVInt(1);
            this.m_stream.WriteVInt(0);
            this.m_stream.WriteString(null);
            this.m_stream.WriteVInt(1);
            this.m_stream.WriteVInt(0);
            this.m_stream.WriteInt(0);
            this.m_stream.WriteInt(0);
            this.m_stream.WriteString(null);

        }
        public override void Decode()
        {
            this.m_accountId = this.m_stream.ReadLong();
            this.m_passToken = this.m_stream.ReadString(900000);
            this.m_clientMajorVersion = this.m_stream.ReadInt();
            this.m_stream.ReadInt();
            this.m_clientBuildVersion = this.m_stream.ReadInt();
            this.m_resourceSha = this.m_stream.ReadString(900000);
            this.m_udid = this.m_stream.ReadString(900000);
            this.m_stream.ReadVInt();
            this.m_stream.ReadVInt();
            this.m_openUDID = this.m_stream.ReadString(900000);
            this.m_stream.ReadString(900000);
            this.m_stream.ReadInt();
            this.m_stream.ReadVInt();
            this.m_stream.ReadString(900000);
            this.m_stream.ReadVInt();
            this.m_stream.ReadVInt();
            this.m_stream.ReadInt();
            this.m_stream.ReadInt();
            this.m_stream.ReadString(900000);
        }

        public override short GetMessageType()
        {
            return LoginMessage.MESSAGE_TYPE;
        }

        public override int GetServiceNodeType()
        {
            return 1;
        }

        public override void Destruct()
        {
            base.Destruct();

            this.m_adid = null;
            this.m_passToken = null;
            this.m_device = null;
            this.m_imei = null;
            this.m_macAddress = null;
            this.m_osVersion = null;
            this.m_androidId = null;
            this.m_openUDID = null;
            this.m_preferredDeviceLanguage = null;
            this.m_resourceSha = null;
            this.m_kunlunSSO = null;
            this.m_kunlunUserId = null;
            this.m_udid = null;
        }

        public LogicLong GetAccountId()
        {
            return this.m_accountId;
        }

        public void SetAccountId(LogicLong value)
        {
            this.m_accountId = value;
        }

        public bool IsAndroidClient()
        {
            return this.m_androidClient;
        }

        public void SetAndroidClient(bool value)
        {
            this.m_androidClient = value;
        }

        public bool IsAdvertisingEnabled()
        {
            return this.m_advertisingEnabled;
        }

        public void SetAdvertisingEnabled(bool value)
        {
            this.m_advertisingEnabled = value;
        }

        public int GetScramblerSeed()
        {
            return this.m_scramblerSeed;
        }

        public void SetScramblerSeed(int value)
        {
            this.m_scramblerSeed = value;
        }

        public int GetClientMajorVersion()
        {
            return this.m_clientMajorVersion;
        }

        public void SetClientMajorVersion(int value)
        {
            this.m_clientMajorVersion = value;
        }

        public int GetClientBuildVersion()
        {
            return this.m_clientBuildVersion;
        }

        public void SetClientBuildVersion(int value)
        {
            this.m_clientBuildVersion = value;
        }

        public int GetAppStore()
        {
            return this.m_appStore;
        }

        public void SetAppStore(int value)
        {
            this.m_appStore = value;
        }

        public string GetAndroidID()
        {
            return this.m_androidId;
        }

        public void SetAndroidID(string value)
        {
            this.m_androidId = value;
        }

        public string GetADID()
        {
            return this.m_adid;
        }

        public void SetADID(string value)
        {
            this.m_adid = value;
        }

        public string GetDevice()
        {
            return this.m_device;
        }

        public void SetDevice(string value)
        {
            this.m_device = value;
        }

        public string GetIMEI()
        {
            return this.m_imei;
        }

        public void SetIMEI(string value)
        {
            this.m_imei = value;
        }

        public string GetMacAddress()
        {
            return this.m_macAddress;
        }

        public void SetMacAddress(string value)
        {
            this.m_macAddress = value;
        }

        public string GetOpenUDID()
        {
            return this.m_openUDID;
        }

        public void SetOpenUDID(string value)
        {
            this.m_openUDID = value;
        }

        public string GetOSVersion()
        {
            return this.m_osVersion;
        }

        public void SetOSVersion(string value)
        {
            this.m_osVersion = value;
        }

        public string GetAdvertisingId()
        {
            return this.m_advertisingId;
        }

        public void SetAdvertisingId(string value)
        {
            this.m_advertisingId = value;
        }

        public string GetAppVersion()
        {
            return this.m_appVersion;
        }

        public void SetAppVersion(string value)
        {
            this.m_appVersion = value;
        }

        public string GetPassToken()
        {
            return this.m_passToken;
        }

        public void SetPassToken(string value)
        {
            this.m_passToken = value;
        }

        public string GetPreferredDeviceLanguage()
        {
            return this.m_preferredDeviceLanguage;
        }

        public void SetPreferredDeviceLanguage(string value)
        {
            this.m_preferredDeviceLanguage = value;
        }

        public string GetResourceSha()
        {
            return this.m_resourceSha;
        }

        public void SetResourceSha(string value)
        {
            this.m_resourceSha = value;
        }

        public string GetUDID()
        {
            return this.m_udid;
        }

        public void SetUDID(string value)
        {
            this.m_udid = value;
        }

        public string GetKunlunSSO()
        {
            return this.m_kunlunSSO;
        }

        public void SetKunlunSSO(string value)
        {
            this.m_kunlunSSO = value;
        }

        public string GetKunlunUID()
        {
            return this.m_kunlunUserId;
        }

        public void SetKunlunUID(string value)
        {
            this.m_kunlunUserId = value;
        }
    }
}
