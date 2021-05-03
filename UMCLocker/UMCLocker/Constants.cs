using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMCLocker
{
    public static class Constants
    {
        public static char UNDERSCORE = '_';
        public static char COMMA = ',';
        public static string SERAPATOR = @"\";
        public static char DOT = '.';
        public static string VALUE_DEFAULT = "N/A";
        public static string NOTICE_INSERT_FAILED = "Insert failed!";
        public static string NOTICE_UPDATE_FAILED = "Update failed!";
        public static string NOTICE_DELETE_FAILED = "Delete failed!";
        public static string NOTICE_DELETE_FOREIGN_KEY = "{0} đang dùng khóa này. Bạn cầ đổi khóa cho họ!";
        public static string DUPPLICATE = "Duplicate!";
        public static string REQUIRED = "( * )";
        public static string FILTERED = "1";
        public static string ALL_LIST = "0";
        public static string ALL_FILTER = "ALL";
        public static string MALE = "M";
        public static string FEMALE = "F";
        public static string NO_DATA = "";
        public static int ERROR_COMMON = -1;
        public static int ERROR_DUPLICATE_DATA = -2;
        public static int ERROR_DELETE_FOREIGN_FIRST = -3;
        public static int ERROR_KEY_USED = -4;
        public static int ERROR_KEY_NOT_EXIST = -5;
        public static int ERROR_LACK_KEY = -6;


        public static int SUCCESS = 0;
        public static string CONFIRM_DELETE_STAFF = "Bạn có muốn cho {0} vào danh sách nghỉ việc không?";
        public static string CONFIRM_DELETE_STAFF_FOREVER = "Sau khi xóa bạn sẽ không thể lấy lại tất cả dữ liệu của {0}!!";
        public static string CONFIRM_DELETE_DEPT = "Bạn có muốn xóa phòng {0} không?";
        public static string CONFIRM_DELETE_POS = "Bạn có muốn xóa chức vụ {0} không?";
        public static string CONFIRM_DELETE_KEY = "Bạn có muốn xóa khóa {0} không?";
        public static string CONFIRM_SAVE_STAFF = "Bạn có muốn lưu không?";
        public static string CONFIRM_CLOSE_WITHOUT_SAVE = "Do you want to close without save?";
        public static string TAPPAGE_STAFF = "tPStaff";
        public static string TAPPAGE_KEY = "tPKey";
        public static string TAPPAGE_DEPT = "tPDept";
        public static string TAPPAGE_POS = "tPPos";
        public static int FILTER_ID = 0;
        public static int FILTER_STAFFCODE = 1;
        public static int FILTER_FULLNAME = 2;
        public static string NOTICE_KEY_EXIST = "Key already exist!";
        public static string PLACEHOLDER_SEARCH = "Nhập mã nhân viên...";
        public static string STATE_AVAIABLE = "AVAIABLE";
        public static string STATE_USED = "USED";
        public static string STATE_ON = "ON";
        public static string STATE_OFF = "OFF";
        public static string NOTE_NOT_RETURN_KEY = "NV không trả khóa";
        public static string NOTE_RETURN_KEY = "NV có trả khóa";
        public static string LOCKER = "L";
        public static string SHOES = "S";
        public static string EXCEL_STAFF = "Danh sách nhân viên sử dụng khóa";
        public static string EXCEL_STAFF_LIQUITE = "Danh sách nhân viên nghỉ việc";

    }
    public enum FormType
    {
        New,
        Edit,
        View,
        OnlyChangeKeyLocker,
        OnlyChangeKeyShoes
    }

}
