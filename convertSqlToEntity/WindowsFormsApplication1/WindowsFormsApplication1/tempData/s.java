package ff

import java.io.Serializable;
import java.math.BigDecimal;
import java.sql.Timestamp;

public class s implements Serializable {
	private static final long serialVersionUID = 1L;
	
          private String address;
          private long approved_area;
          private Timestamp audit_date;
          private String audit_doc_no;
          private long bill_id;
          private BigDecimal budget_amount;
          private long cons_type_id;
          private String construction_permit_no;
          private Timestamp create_date;
          private long create_user;
          private Timestamp end_date;
          private String finacing_scheme;
          private String financial_officer;
          private long id;
          private long in_mof_dep_id;
          private long in_ps_agency_id;
          private String inv_content;
          private long inv_prj_type_id;
          private String inv_remark;
          private BigDecimal investment_amount;
          private BigDecimal investment_modify_amount;
          private long is_deleted;
          private long is_end;
          private long is_relate_to_land_units;
          private String land_no;
          private String land_permit_no;
          private String land_units_content;
          private Timestamp last_op_date;
          private long last_op_user;
          private String last_op_user_name;
          private long last_ver;
          private long main_id;
          private String name;
          private BigDecimal plan_budget_amount;
          private String plan_permit_no;
          private String pm_leader;
          private String prj_code;
          private long prj_pro_id;
          private long prj_std_id;
          private long rcid;
          private long set_year;
          private Timestamp start_date;

          public String getAddress() {
          	return address;
          }
          public void setAddress(String address) {
          	this.address = address;
          }
          public long getApproved_area() {
          	return approved_area;
          }
          public void setApproved_area(long approved_area) {
          	this.approved_area = approved_area;
          }
          public Timestamp getAudit_date() {
          	return audit_date;
          }
          public void setAudit_date(Timestamp audit_date) {
          	this.audit_date = audit_date;
          }
          public String getAudit_doc_no() {
          	return audit_doc_no;
          }
          public void setAudit_doc_no(String audit_doc_no) {
          	this.audit_doc_no = audit_doc_no;
          }
          public long getBill_id() {
          	return bill_id;
          }
          public void setBill_id(long bill_id) {
          	this.bill_id = bill_id;
          }
          public BigDecimal getBudget_amount() {
          	return budget_amount;
          }
          public void setBudget_amount(BigDecimal budget_amount) {
          	this.budget_amount = budget_amount;
          }
          public long getCons_type_id() {
          	return cons_type_id;
          }
          public void setCons_type_id(long cons_type_id) {
          	this.cons_type_id = cons_type_id;
          }
          public String getConstruction_permit_no() {
          	return construction_permit_no;
          }
          public void setConstruction_permit_no(String construction_permit_no) {
          	this.construction_permit_no = construction_permit_no;
          }
          public Timestamp getCreate_date() {
          	return create_date;
          }
          public void setCreate_date(Timestamp create_date) {
          	this.create_date = create_date;
          }
          public long getCreate_user() {
          	return create_user;
          }
          public void setCreate_user(long create_user) {
          	this.create_user = create_user;
          }
          public Timestamp getEnd_date() {
          	return end_date;
          }
          public void setEnd_date(Timestamp end_date) {
          	this.end_date = end_date;
          }
          public String getFinacing_scheme() {
          	return finacing_scheme;
          }
          public void setFinacing_scheme(String finacing_scheme) {
          	this.finacing_scheme = finacing_scheme;
          }
          public String getFinancial_officer() {
          	return financial_officer;
          }
          public void setFinancial_officer(String financial_officer) {
          	this.financial_officer = financial_officer;
          }
          public long getId() {
          	return id;
          }
          public void setId(long id) {
          	this.id = id;
          }
          public long getIn_mof_dep_id() {
          	return in_mof_dep_id;
          }
          public void setIn_mof_dep_id(long in_mof_dep_id) {
          	this.in_mof_dep_id = in_mof_dep_id;
          }
          public long getIn_ps_agency_id() {
          	return in_ps_agency_id;
          }
          public void setIn_ps_agency_id(long in_ps_agency_id) {
          	this.in_ps_agency_id = in_ps_agency_id;
          }
          public String getInv_content() {
          	return inv_content;
          }
          public void setInv_content(String inv_content) {
          	this.inv_content = inv_content;
          }
          public long getInv_prj_type_id() {
          	return inv_prj_type_id;
          }
          public void setInv_prj_type_id(long inv_prj_type_id) {
          	this.inv_prj_type_id = inv_prj_type_id;
          }
          public String getInv_remark() {
          	return inv_remark;
          }
          public void setInv_remark(String inv_remark) {
          	this.inv_remark = inv_remark;
          }
          public BigDecimal getInvestment_amount() {
          	return investment_amount;
          }
          public void setInvestment_amount(BigDecimal investment_amount) {
          	this.investment_amount = investment_amount;
          }
          public BigDecimal getInvestment_modify_amount() {
          	return investment_modify_amount;
          }
          public void setInvestment_modify_amount(BigDecimal investment_modify_amount) {
          	this.investment_modify_amount = investment_modify_amount;
          }
          public long getIs_deleted() {
          	return is_deleted;
          }
          public void setIs_deleted(long is_deleted) {
          	this.is_deleted = is_deleted;
          }
          public long getIs_end() {
          	return is_end;
          }
          public void setIs_end(long is_end) {
          	this.is_end = is_end;
          }
          public long getIs_relate_to_land_units() {
          	return is_relate_to_land_units;
          }
          public void setIs_relate_to_land_units(long is_relate_to_land_units) {
          	this.is_relate_to_land_units = is_relate_to_land_units;
          }
          public String getLand_no() {
          	return land_no;
          }
          public void setLand_no(String land_no) {
          	this.land_no = land_no;
          }
          public String getLand_permit_no() {
          	return land_permit_no;
          }
          public void setLand_permit_no(String land_permit_no) {
          	this.land_permit_no = land_permit_no;
          }
          public String getLand_units_content() {
          	return land_units_content;
          }
          public void setLand_units_content(String land_units_content) {
          	this.land_units_content = land_units_content;
          }
          public Timestamp getLast_op_date() {
          	return last_op_date;
          }
          public void setLast_op_date(Timestamp last_op_date) {
          	this.last_op_date = last_op_date;
          }
          public long getLast_op_user() {
          	return last_op_user;
          }
          public void setLast_op_user(long last_op_user) {
          	this.last_op_user = last_op_user;
          }
          public String getLast_op_user_name() {
          	return last_op_user_name;
          }
          public void setLast_op_user_name(String last_op_user_name) {
          	this.last_op_user_name = last_op_user_name;
          }
          public long getLast_ver() {
          	return last_ver;
          }
          public void setLast_ver(long last_ver) {
          	this.last_ver = last_ver;
          }
          public long getMain_id() {
          	return main_id;
          }
          public void setMain_id(long main_id) {
          	this.main_id = main_id;
          }
          public String getName() {
          	return name;
          }
          public void setName(String name) {
          	this.name = name;
          }
          public BigDecimal getPlan_budget_amount() {
          	return plan_budget_amount;
          }
          public void setPlan_budget_amount(BigDecimal plan_budget_amount) {
          	this.plan_budget_amount = plan_budget_amount;
          }
          public String getPlan_permit_no() {
          	return plan_permit_no;
          }
          public void setPlan_permit_no(String plan_permit_no) {
          	this.plan_permit_no = plan_permit_no;
          }
          public String getPm_leader() {
          	return pm_leader;
          }
          public void setPm_leader(String pm_leader) {
          	this.pm_leader = pm_leader;
          }
          public String getPrj_code() {
          	return prj_code;
          }
          public void setPrj_code(String prj_code) {
          	this.prj_code = prj_code;
          }
          public long getPrj_pro_id() {
          	return prj_pro_id;
          }
          public void setPrj_pro_id(long prj_pro_id) {
          	this.prj_pro_id = prj_pro_id;
          }
          public long getPrj_std_id() {
          	return prj_std_id;
          }
          public void setPrj_std_id(long prj_std_id) {
          	this.prj_std_id = prj_std_id;
          }
          public long getRcid() {
          	return rcid;
          }
          public void setRcid(long rcid) {
          	this.rcid = rcid;
          }
          public long getSet_year() {
          	return set_year;
          }
          public void setSet_year(long set_year) {
          	this.set_year = set_year;
          }
          public Timestamp getStart_date() {
          	return start_date;
          }
          public void setStart_date(Timestamp start_date) {
          	this.start_date = start_date;
          }

}
