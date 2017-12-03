/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Entidades;

import java.io.Serializable;
import java.math.BigDecimal;
import java.math.BigInteger;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;
import javax.xml.bind.annotation.XmlRootElement;

/**
 *
 * @author PC-Cristopher
 */
@Entity
@Table(name = "VENTAS_BACKUP")
@XmlRootElement
@NamedQueries({
    @NamedQuery(name = "VentasBackup.findAll", query = "SELECT v FROM VentasBackup v")
    , @NamedQuery(name = "VentasBackup.findByIdRes", query = "SELECT v FROM VentasBackup v WHERE v.idRes = :idRes")
    , @NamedQuery(name = "VentasBackup.findBySubtotalRes", query = "SELECT v FROM VentasBackup v WHERE v.subtotalRes = :subtotalRes")
    , @NamedQuery(name = "VentasBackup.findByPropinaRes", query = "SELECT v FROM VentasBackup v WHERE v.propinaRes = :propinaRes")
    , @NamedQuery(name = "VentasBackup.findByTotalRes", query = "SELECT v FROM VentasBackup v WHERE v.totalRes = :totalRes")
    , @NamedQuery(name = "VentasBackup.findByPedidoidRes", query = "SELECT v FROM VentasBackup v WHERE v.pedidoidRes = :pedidoidRes")})
public class VentasBackup implements Serializable {

    private static final long serialVersionUID = 1L;
    // @Max(value=?)  @Min(value=?)//if you know range of your decimal fields consider using these annotations to enforce field validation
    @Id
    @Basic(optional = false)
    @NotNull
    @Column(name = "ID_RES")
    private BigDecimal idRes;
    @Basic(optional = false)
    @NotNull
    @Column(name = "SUBTOTAL_RES")
    private BigInteger subtotalRes;
    @Basic(optional = false)
    @NotNull
    @Column(name = "PROPINA_RES")
    private BigInteger propinaRes;
    @Basic(optional = false)
    @NotNull
    @Column(name = "TOTAL_RES")
    private BigInteger totalRes;
    @Basic(optional = false)
    @NotNull
    @Column(name = "PEDIDOID_RES")
    private BigInteger pedidoidRes;

    public VentasBackup() {
    }

    public VentasBackup(BigDecimal idRes) {
        this.idRes = idRes;
    }

    public VentasBackup(BigDecimal idRes, BigInteger subtotalRes, BigInteger propinaRes, BigInteger totalRes, BigInteger pedidoidRes) {
        this.idRes = idRes;
        this.subtotalRes = subtotalRes;
        this.propinaRes = propinaRes;
        this.totalRes = totalRes;
        this.pedidoidRes = pedidoidRes;
    }

    public BigDecimal getIdRes() {
        return idRes;
    }

    public void setIdRes(BigDecimal idRes) {
        this.idRes = idRes;
    }

    public BigInteger getSubtotalRes() {
        return subtotalRes;
    }

    public void setSubtotalRes(BigInteger subtotalRes) {
        this.subtotalRes = subtotalRes;
    }

    public BigInteger getPropinaRes() {
        return propinaRes;
    }

    public void setPropinaRes(BigInteger propinaRes) {
        this.propinaRes = propinaRes;
    }

    public BigInteger getTotalRes() {
        return totalRes;
    }

    public void setTotalRes(BigInteger totalRes) {
        this.totalRes = totalRes;
    }

    public BigInteger getPedidoidRes() {
        return pedidoidRes;
    }

    public void setPedidoidRes(BigInteger pedidoidRes) {
        this.pedidoidRes = pedidoidRes;
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (idRes != null ? idRes.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof VentasBackup)) {
            return false;
        }
        VentasBackup other = (VentasBackup) object;
        if ((this.idRes == null && other.idRes != null) || (this.idRes != null && !this.idRes.equals(other.idRes))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "Entidades.VentasBackup[ idRes=" + idRes + " ]";
    }
    
}
