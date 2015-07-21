package grp.budget.ps.model;

import java.io.Serializable;
import java.math.BigDecimal;
import java.sql.Timestamp;

public class TramPfs implements Serializable {
	private static final long serialVersionUID = 1L;
	
          
          //单据类型
          private long bill_type_id;
          
          //创建日期
          private Timestamp create_date;
          
          //创建人
          private long create_user;
          
          //创建人名称
          private String create_user_name;
          
          //指标文号
          private String doc_no_name;
          
          //功能科目ID
          private long exp_func_id;
          
          //主键
          private long id;
          
          //类别
          private long kind;
          
          //最后操作日期
          private Timestamp last_op_date;
          
          //最后操作人
          private long last_op_user;
          
          //最后操作人名称
          private String last_op_user_name;
          
          //版本号
          private long last_ver;
          
          //流转单
          private long modulate_bill_id;
          
          //项目名称
          private String name;
          
          //金额
          private BigDecimal pfs_amount;
          
          //预算类型id
          private long prj_budget_type_id;
          
          //调入预算明细ID
          private long ps_pfs_id;
          
          private long rcid;
          
          //指标id
          private long tran_id;

          public long getBill_type_id() {
          	return bill_type_id;
          }
          public void setBill_type_id(long bill_type_id) {
          	this.bill_type_id = bill_type_id;
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
          public String getCreate_user_name() {
          	return create_user_name;
          }
          public void setCreate_user_name(String create_user_name) {
          	this.create_user_name = create_user_name;
          }
          public String getDoc_no_name() {
          	return doc_no_name;
          }
          public void setDoc_no_name(String doc_no_name) {
          	this.doc_no_name = doc_no_name;
          }
          public long getExp_func_id() {
          	return exp_func_id;
          }
          public void setExp_func_id(long exp_func_id) {
          	this.exp_func_id = exp_func_id;
          }
          public long getId() {
          	return id;
          }
          public void setId(long id) {
          	this.id = id;
          }
          public long getKind() {
          	return kind;
          }
          public void setKind(long kind) {
          	this.kind = kind;
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
          public long getModulate_bill_id() {
          	return modulate_bill_id;
          }
          public void setModulate_bill_id(long modulate_bill_id) {
          	this.modulate_bill_id = modulate_bill_id;
          }
          public String getName() {
          	return name;
          }
          public void setName(String name) {
          	this.name = name;
          }
          public BigDecimal getPfs_amount() {
          	return pfs_amount;
          }
          public void setPfs_amount(BigDecimal pfs_amount) {
          	this.pfs_amount = pfs_amount;
          }
          public long getPrj_budget_type_id() {
          	return prj_budget_type_id;
          }
          public void setPrj_budget_type_id(long prj_budget_type_id) {
          	this.prj_budget_type_id = prj_budget_type_id;
          }
          public long getPs_pfs_id() {
          	return ps_pfs_id;
          }
          public void setPs_pfs_id(long ps_pfs_id) {
          	this.ps_pfs_id = ps_pfs_id;
          }
          public long getRcid() {
          	return rcid;
          }
          public void setRcid(long rcid) {
          	this.rcid = rcid;
          }
          public long getTran_id() {
          	return tran_id;
          }
          public void setTran_id(long tran_id) {
          	this.tran_id = tran_id;
          }

}
